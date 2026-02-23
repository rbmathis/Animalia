using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Grammatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Grammatidae.Gramma;

/// <summary>
/// Abstract class for Gramma (genus).
/// NCBI TaxId: 274799
/// </summary>
public abstract class Gramma : Grammatidae, IGramma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gramma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 274799;

    /// <inheritdoc />
    public virtual string GenusName => "Gramma";

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
