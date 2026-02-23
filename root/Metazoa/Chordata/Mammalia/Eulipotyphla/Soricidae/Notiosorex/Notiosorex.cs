using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Notiosorex;

/// <summary>
/// Abstract class for Notiosorex (genus).
/// NCBI TaxId: 234933
/// </summary>
public abstract class Notiosorex : Soricidae, INotiosorex
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Notiosorex";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 234933;

    /// <inheritdoc />
    public virtual string GenusName => "Notiosorex";

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
