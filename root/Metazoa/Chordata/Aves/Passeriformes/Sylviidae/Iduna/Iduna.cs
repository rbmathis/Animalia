using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae.Iduna;

/// <summary>
/// Abstract class for Iduna (genus).
/// NCBI TaxId: 659170
/// </summary>
public abstract class Iduna : Sylviidae, IIduna
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Iduna";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 659170;

    /// <inheritdoc />
    public virtual string GenusName => "Iduna";

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
