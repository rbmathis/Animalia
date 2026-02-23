using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Plesiopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Plesiopidae.Trachinops;

/// <summary>
/// Abstract class for Trachinops (genus).
/// NCBI TaxId: 1040956
/// </summary>
public abstract class Trachinops : Plesiopidae, ITrachinops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trachinops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1040956;

    /// <inheritdoc />
    public virtual string GenusName => "Trachinops";

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
