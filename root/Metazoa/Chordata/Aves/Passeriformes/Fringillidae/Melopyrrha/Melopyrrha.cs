using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Melopyrrha;

/// <summary>
/// Abstract class for Melopyrrha (genus).
/// NCBI TaxId: 137214
/// </summary>
public abstract class Melopyrrha : Fringillidae, IMelopyrrha
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Melopyrrha";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 137214;

    /// <inheritdoc />
    public virtual string GenusName => "Melopyrrha";

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
