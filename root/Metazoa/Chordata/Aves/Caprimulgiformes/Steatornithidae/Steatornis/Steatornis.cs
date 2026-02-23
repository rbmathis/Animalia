using AnimalKingdom.root.Metazoa.Chordata.Aves.Caprimulgiformes.Steatornithidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Caprimulgiformes.Steatornithidae.Steatornis;

/// <summary>
/// Abstract class for Steatornis (genus).
/// NCBI TaxId: 48434
/// </summary>
public abstract class Steatornis : Steatornithidae, ISteatornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Steatornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 48434;

    /// <inheritdoc />
    public virtual string GenusName => "Steatornis";

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
