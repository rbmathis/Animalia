using AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Psammobates;

/// <summary>
/// Abstract class for Psammobates (genus).
/// NCBI TaxId: 286012
/// </summary>
public abstract class Psammobates : Testudinidae, IPsammobates
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Psammobates";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 286012;

    /// <inheritdoc />
    public virtual string GenusName => "Psammobates";

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
