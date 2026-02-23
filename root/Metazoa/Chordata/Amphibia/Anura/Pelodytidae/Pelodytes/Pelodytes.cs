using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodytidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodytidae.Pelodytes;

/// <summary>
/// Abstract class for Pelodytes (genus).
/// NCBI TaxId: 43541
/// </summary>
public abstract class Pelodytes : Pelodytidae, IPelodytes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pelodytes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 43541;

    /// <inheritdoc />
    public virtual string GenusName => "Pelodytes";

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
