using AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Threskiornithidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Threskiornithidae.Threskiornis;

/// <summary>
/// Abstract class for Threskiornis (genus).
/// NCBI TaxId: 100857
/// </summary>
public abstract class Threskiornis : Threskiornithidae, IThreskiornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Threskiornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 100857;

    /// <inheritdoc />
    public virtual string GenusName => "Threskiornis";

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
