using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Mycerobas;

/// <summary>
/// Abstract class for Mycerobas (genus).
/// NCBI TaxId: 175944
/// </summary>
public abstract class Mycerobas : Fringillidae, IMycerobas
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mycerobas";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 175944;

    /// <inheritdoc />
    public virtual string GenusName => "Mycerobas";

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
