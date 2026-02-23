using AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Procellariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Procellariidae.Procellaria;

/// <summary>
/// Abstract class for Procellaria (genus).
/// NCBI TaxId: 37061
/// </summary>
public abstract class Procellaria : Procellariidae, IProcellaria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Procellaria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 37061;

    /// <inheritdoc />
    public virtual string GenusName => "Procellaria";

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
