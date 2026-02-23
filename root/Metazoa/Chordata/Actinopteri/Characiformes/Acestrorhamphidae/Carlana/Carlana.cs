using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Carlana;

/// <summary>
/// Abstract class for Carlana (genus).
/// NCBI TaxId: 930306
/// </summary>
public abstract class Carlana : Acestrorhamphidae, ICarlana
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Carlana";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 930306;

    /// <inheritdoc />
    public virtual string GenusName => "Carlana";

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
