using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Perisoreus;

/// <summary>
/// Abstract class for Perisoreus (genus).
/// NCBI TaxId: 54572
/// </summary>
public abstract class Perisoreus : Corvidae, IPerisoreus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Perisoreus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 54572;

    /// <inheritdoc />
    public virtual string GenusName => "Perisoreus";

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
