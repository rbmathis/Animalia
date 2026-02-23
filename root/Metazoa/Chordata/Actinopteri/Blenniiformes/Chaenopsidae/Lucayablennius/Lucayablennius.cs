using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Chaenopsidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Chaenopsidae.Lucayablennius;

/// <summary>
/// Abstract class for Lucayablennius (genus).
/// NCBI TaxId: 642455
/// </summary>
public abstract class Lucayablennius : Chaenopsidae, ILucayablennius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lucayablennius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 642455;

    /// <inheritdoc />
    public virtual string GenusName => "Lucayablennius";

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
