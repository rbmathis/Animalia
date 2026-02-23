using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paradisaeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paradisaeidae.Drepanornis;

/// <summary>
/// Abstract class for Drepanornis (genus).
/// NCBI TaxId: 681189
/// </summary>
public abstract class Drepanornis : Paradisaeidae, IDrepanornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Drepanornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 681189;

    /// <inheritdoc />
    public virtual string GenusName => "Drepanornis";

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
