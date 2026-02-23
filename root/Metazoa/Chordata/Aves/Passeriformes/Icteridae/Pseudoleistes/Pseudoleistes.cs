using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae.Pseudoleistes;

/// <summary>
/// Abstract class for Pseudoleistes (genus).
/// NCBI TaxId: 84848
/// </summary>
public abstract class Pseudoleistes : Icteridae, IPseudoleistes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudoleistes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 84848;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudoleistes";

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
