using AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Megalaimidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Megalaimidae.Psilopogon;

/// <summary>
/// Abstract class for Psilopogon (genus).
/// NCBI TaxId: 91776
/// </summary>
public abstract class Psilopogon : Megalaimidae, IPsilopogon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Psilopogon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 91776;

    /// <inheritdoc />
    public virtual string GenusName => "Psilopogon";

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
