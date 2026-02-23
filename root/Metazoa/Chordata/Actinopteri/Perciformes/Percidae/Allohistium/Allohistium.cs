using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Percidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Percidae.Allohistium;

/// <summary>
/// Abstract class for Allohistium (genus).
/// NCBI TaxId: 909710
/// </summary>
public abstract class Allohistium : Percidae, IAllohistium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Allohistium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 909710;

    /// <inheritdoc />
    public virtual string GenusName => "Allohistium";

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
