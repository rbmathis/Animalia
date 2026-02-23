using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Psilorhinus;

/// <summary>
/// Abstract class for Psilorhinus (genus).
/// NCBI TaxId: 114088
/// </summary>
public abstract class Psilorhinus : Corvidae, IPsilorhinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Psilorhinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 114088;

    /// <inheritdoc />
    public virtual string GenusName => "Psilorhinus";

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
