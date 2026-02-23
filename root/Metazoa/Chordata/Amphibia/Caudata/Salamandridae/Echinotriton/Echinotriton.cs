using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Salamandridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Salamandridae.Echinotriton;

/// <summary>
/// Abstract class for Echinotriton (genus).
/// NCBI TaxId: 385652
/// </summary>
public abstract class Echinotriton : Salamandridae, IEchinotriton
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Echinotriton";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 385652;

    /// <inheritdoc />
    public virtual string GenusName => "Echinotriton";

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
