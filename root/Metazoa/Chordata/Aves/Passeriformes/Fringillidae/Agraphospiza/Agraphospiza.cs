using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Agraphospiza;

/// <summary>
/// Abstract class for Agraphospiza (genus).
/// NCBI TaxId: 3150750
/// </summary>
public abstract class Agraphospiza : Fringillidae, IAgraphospiza
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Agraphospiza";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3150750;

    /// <inheritdoc />
    public virtual string GenusName => "Agraphospiza";

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
