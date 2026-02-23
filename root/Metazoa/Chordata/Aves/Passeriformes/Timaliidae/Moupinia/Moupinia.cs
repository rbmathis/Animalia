using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Timaliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Timaliidae.Moupinia;

/// <summary>
/// Abstract class for Moupinia (genus).
/// NCBI TaxId: 1149628
/// </summary>
public abstract class Moupinia : Timaliidae, IMoupinia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Moupinia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1149628;

    /// <inheritdoc />
    public virtual string GenusName => "Moupinia";

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
