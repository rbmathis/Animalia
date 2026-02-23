using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Micrixalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Micrixalidae.Micrixalus;

/// <summary>
/// Abstract class for Micrixalus (genus).
/// NCBI TaxId: 129015
/// </summary>
public abstract class Micrixalus : Micrixalidae, IMicrixalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Micrixalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 129015;

    /// <inheritdoc />
    public virtual string GenusName => "Micrixalus";

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
