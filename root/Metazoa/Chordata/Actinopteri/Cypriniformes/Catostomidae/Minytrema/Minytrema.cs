using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Catostomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Catostomidae.Minytrema;

/// <summary>
/// Abstract class for Minytrema (genus).
/// NCBI TaxId: 154818
/// </summary>
public abstract class Minytrema : Catostomidae, IMinytrema
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Minytrema";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 154818;

    /// <inheritdoc />
    public virtual string GenusName => "Minytrema";

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
