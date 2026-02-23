using AnimalKingdom.root.Metazoa.Chordata.Aves.Musophagiformes.Musophagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Musophagiformes.Musophagidae.Corythaixoides;

/// <summary>
/// Abstract class for Corythaixoides (genus).
/// NCBI TaxId: 103955
/// </summary>
public abstract class Corythaixoides : Musophagidae, ICorythaixoides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Corythaixoides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 103955;

    /// <inheritdoc />
    public virtual string GenusName => "Corythaixoides";

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
