using AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Geochelone;

/// <summary>
/// Abstract class for Geochelone (genus).
/// NCBI TaxId: 50046
/// </summary>
public abstract class Geochelone : Testudinidae, IGeochelone
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Geochelone";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 50046;

    /// <inheritdoc />
    public virtual string GenusName => "Geochelone";

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
