using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Scyliorhinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Scyliorhinidae.Schroederichthys;

/// <summary>
/// Abstract class for Schroederichthys (genus).
/// NCBI TaxId: 458608
/// </summary>
public abstract class Schroederichthys : Scyliorhinidae, ISchroederichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Schroederichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 458608;

    /// <inheritdoc />
    public virtual string GenusName => "Schroederichthys";

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
