using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae.Tesia;

/// <summary>
/// Abstract class for Tesia (genus).
/// NCBI TaxId: 330763
/// </summary>
public abstract class Tesia : Sylviidae, ITesia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tesia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 330763;

    /// <inheritdoc />
    public virtual string GenusName => "Tesia";

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
