using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Scandentia.Tupaiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Scandentia.Tupaiidae.Anathana;

/// <summary>
/// Abstract class for Anathana (genus).
/// NCBI TaxId: 320339
/// </summary>
public abstract class Anathana : Tupaiidae, IAnathana
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anathana";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 320339;

    /// <inheritdoc />
    public virtual string GenusName => "Anathana";

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
