using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae.Pogonocichla;

/// <summary>
/// Abstract class for Pogonocichla (genus).
/// NCBI TaxId: 228320
/// </summary>
public abstract class Pogonocichla : Muscicapidae, IPogonocichla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pogonocichla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 228320;

    /// <inheritdoc />
    public virtual string GenusName => "Pogonocichla";

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
