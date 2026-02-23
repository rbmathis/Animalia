using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Polymixiiformes.Polymixiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Polymixiiformes.Polymixiidae.Polymixia;

/// <summary>
/// Abstract class for Polymixia (genus).
/// NCBI TaxId: 81384
/// </summary>
public abstract class Polymixia : Polymixiidae, IPolymixia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Polymixia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 81384;

    /// <inheritdoc />
    public virtual string GenusName => "Polymixia";

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
