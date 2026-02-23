using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Diporiphora;

/// <summary>
/// Abstract class for Diporiphora (genus).
/// NCBI TaxId: 118203
/// </summary>
public abstract class Diporiphora : Agamidae, IDiporiphora
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Diporiphora";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 118203;

    /// <inheritdoc />
    public virtual string GenusName => "Diporiphora";

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
