using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae.Hemitesia;

/// <summary>
/// Abstract class for Hemitesia (genus).
/// NCBI TaxId: 886685
/// </summary>
public abstract class Hemitesia : Sylviidae, IHemitesia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hemitesia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 886685;

    /// <inheritdoc />
    public virtual string GenusName => "Hemitesia";

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
