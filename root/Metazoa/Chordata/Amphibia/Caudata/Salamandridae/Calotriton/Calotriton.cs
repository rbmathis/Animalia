using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Salamandridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Salamandridae.Calotriton;

/// <summary>
/// Abstract class for Calotriton (genus).
/// NCBI TaxId: 342569
/// </summary>
public abstract class Calotriton : Salamandridae, ICalotriton
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Calotriton";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 342569;

    /// <inheritdoc />
    public virtual string GenusName => "Calotriton";

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
