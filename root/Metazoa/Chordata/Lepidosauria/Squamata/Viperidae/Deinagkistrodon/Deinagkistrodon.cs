using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae.Deinagkistrodon;

/// <summary>
/// Abstract class for Deinagkistrodon (genus).
/// NCBI TaxId: 42170
/// </summary>
public abstract class Deinagkistrodon : Viperidae, IDeinagkistrodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Deinagkistrodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 42170;

    /// <inheritdoc />
    public virtual string GenusName => "Deinagkistrodon";

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
