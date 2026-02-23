using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae.Rhynchospiza;

/// <summary>
/// Abstract class for Rhynchospiza (genus).
/// NCBI TaxId: 2704512
/// </summary>
public abstract class Rhynchospiza : Passerellidae, IRhynchospiza
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhynchospiza";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2704512;

    /// <inheritdoc />
    public virtual string GenusName => "Rhynchospiza";

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
