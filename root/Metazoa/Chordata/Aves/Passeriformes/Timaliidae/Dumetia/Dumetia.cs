using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Timaliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Timaliidae.Dumetia;

/// <summary>
/// Abstract class for Dumetia (genus).
/// NCBI TaxId: 634295
/// </summary>
public abstract class Dumetia : Timaliidae, IDumetia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dumetia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 634295;

    /// <inheritdoc />
    public virtual string GenusName => "Dumetia";

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
