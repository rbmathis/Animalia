using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae.Cerastes;

/// <summary>
/// Abstract class for Cerastes (genus).
/// NCBI TaxId: 8696
/// </summary>
public abstract class Cerastes : Viperidae, ICerastes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cerastes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8696;

    /// <inheritdoc />
    public virtual string GenusName => "Cerastes";

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
