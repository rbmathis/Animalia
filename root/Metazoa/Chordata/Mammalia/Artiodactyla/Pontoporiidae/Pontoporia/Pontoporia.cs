using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Pontoporiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Pontoporiidae.Pontoporia;

/// <summary>
/// Abstract class for Pontoporia (genus).
/// NCBI TaxId: 48722
/// </summary>
public abstract class Pontoporia : Pontoporiidae, IPontoporia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pontoporia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 48722;

    /// <inheritdoc />
    public virtual string GenusName => "Pontoporia";

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
