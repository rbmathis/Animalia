using AnimalKingdom.root.Metazoa.Chordata.Aves.Caprimulgiformes.Caprimulgidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Caprimulgiformes.Caprimulgidae.Lyncornis;

/// <summary>
/// Abstract class for Lyncornis (genus).
/// NCBI TaxId: 1977168
/// </summary>
public abstract class Lyncornis : Caprimulgidae, ILyncornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lyncornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1977168;

    /// <inheritdoc />
    public virtual string GenusName => "Lyncornis";

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
