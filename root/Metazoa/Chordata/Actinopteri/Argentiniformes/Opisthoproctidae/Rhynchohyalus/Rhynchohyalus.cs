using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Argentiniformes.Opisthoproctidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Argentiniformes.Opisthoproctidae.Rhynchohyalus;

/// <summary>
/// Abstract class for Rhynchohyalus (genus).
/// NCBI TaxId: 1311560
/// </summary>
public abstract class Rhynchohyalus : Opisthoproctidae, IRhynchohyalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhynchohyalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1311560;

    /// <inheritdoc />
    public virtual string GenusName => "Rhynchohyalus";

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
