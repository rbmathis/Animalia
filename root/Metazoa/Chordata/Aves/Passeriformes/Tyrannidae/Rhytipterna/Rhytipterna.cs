using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Rhytipterna;

/// <summary>
/// Abstract class for Rhytipterna (genus).
/// NCBI TaxId: 204061
/// </summary>
public abstract class Rhytipterna : Tyrannidae, IRhytipterna
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhytipterna";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 204061;

    /// <inheritdoc />
    public virtual string GenusName => "Rhytipterna";

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
