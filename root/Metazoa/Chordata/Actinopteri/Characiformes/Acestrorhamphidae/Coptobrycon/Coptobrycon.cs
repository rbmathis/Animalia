using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Coptobrycon;

/// <summary>
/// Abstract class for Coptobrycon (genus).
/// NCBI TaxId: 930314
/// </summary>
public abstract class Coptobrycon : Acestrorhamphidae, ICoptobrycon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Coptobrycon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 930314;

    /// <inheritdoc />
    public virtual string GenusName => "Coptobrycon";

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
