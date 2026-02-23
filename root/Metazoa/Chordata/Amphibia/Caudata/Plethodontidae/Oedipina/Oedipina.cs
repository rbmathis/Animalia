using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae.Oedipina;

/// <summary>
/// Abstract class for Oedipina (genus).
/// NCBI TaxId: 107969
/// </summary>
public abstract class Oedipina : Plethodontidae, IOedipina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oedipina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 107969;

    /// <inheritdoc />
    public virtual string GenusName => "Oedipina";

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
