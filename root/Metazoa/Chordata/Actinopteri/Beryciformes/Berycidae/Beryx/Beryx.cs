using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes.Berycidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes.Berycidae.Beryx;

/// <summary>
/// Abstract class for Beryx (genus).
/// NCBI TaxId: 88662
/// </summary>
public abstract class Beryx : Berycidae, IBeryx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Beryx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 88662;

    /// <inheritdoc />
    public virtual string GenusName => "Beryx";

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
