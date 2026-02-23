using AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Procellariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Procellariidae.Fulmarus;

/// <summary>
/// Abstract class for Fulmarus (genus).
/// NCBI TaxId: 30454
/// </summary>
public abstract class Fulmarus : Procellariidae, IFulmarus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Fulmarus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 30454;

    /// <inheritdoc />
    public virtual string GenusName => "Fulmarus";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
