using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Loxia;

/// <summary>
/// Abstract class for Loxia (genus).
/// NCBI TaxId: 64794
/// </summary>
public abstract class Loxia : Fringillidae, ILoxia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Loxia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 64794;

    /// <inheritdoc />
    public virtual string GenusName => "Loxia";

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
