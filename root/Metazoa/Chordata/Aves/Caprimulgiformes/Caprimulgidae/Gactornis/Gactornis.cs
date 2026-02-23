using AnimalKingdom.root.Metazoa.Chordata.Aves.Caprimulgiformes.Caprimulgidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Caprimulgiformes.Caprimulgidae.Gactornis;

/// <summary>
/// Abstract class for Gactornis (genus).
/// NCBI TaxId: 1854003
/// </summary>
public abstract class Gactornis : Caprimulgidae, IGactornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gactornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1854003;

    /// <inheritdoc />
    public virtual string GenusName => "Gactornis";

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
