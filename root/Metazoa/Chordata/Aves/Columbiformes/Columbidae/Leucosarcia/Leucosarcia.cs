using AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Leucosarcia;

/// <summary>
/// Abstract class for Leucosarcia (genus).
/// NCBI TaxId: 115672
/// </summary>
public abstract class Leucosarcia : Columbidae, ILeucosarcia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leucosarcia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 115672;

    /// <inheritdoc />
    public virtual string GenusName => "Leucosarcia";

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
