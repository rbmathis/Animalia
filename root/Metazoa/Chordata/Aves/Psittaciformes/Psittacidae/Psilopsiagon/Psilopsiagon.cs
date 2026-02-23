using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Psilopsiagon;

/// <summary>
/// Abstract class for Psilopsiagon (genus).
/// NCBI TaxId: 555337
/// </summary>
public abstract class Psilopsiagon : Psittacidae, IPsilopsiagon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Psilopsiagon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 555337;

    /// <inheritdoc />
    public virtual string GenusName => "Psilopsiagon";

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
