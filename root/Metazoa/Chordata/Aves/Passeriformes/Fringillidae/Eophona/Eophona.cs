using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Eophona;

/// <summary>
/// Abstract class for Eophona (genus).
/// NCBI TaxId: 175940
/// </summary>
public abstract class Eophona : Fringillidae, IEophona
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eophona";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 175940;

    /// <inheritdoc />
    public virtual string GenusName => "Eophona";

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
