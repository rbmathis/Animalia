using AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Procellariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Procellariidae.Halobaena;

/// <summary>
/// Abstract class for Halobaena (genus).
/// NCBI TaxId: 79654
/// </summary>
public abstract class Halobaena : Procellariidae, IHalobaena
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Halobaena";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 79654;

    /// <inheritdoc />
    public virtual string GenusName => "Halobaena";

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
