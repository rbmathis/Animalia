using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes.Barbourisiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes.Barbourisiidae.Barbourisia;

/// <summary>
/// Abstract class for Barbourisia (genus).
/// NCBI TaxId: 88659
/// </summary>
public abstract class Barbourisia : Barbourisiidae, IBarbourisia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Barbourisia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 88659;

    /// <inheritdoc />
    public virtual string GenusName => "Barbourisia";

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
