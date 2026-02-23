using AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Lophodytes;

/// <summary>
/// Abstract class for Lophodytes (genus).
/// NCBI TaxId: 279950
/// </summary>
public abstract class Lophodytes : Anatidae, ILophodytes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lophodytes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 279950;

    /// <inheritdoc />
    public virtual string GenusName => "Lophodytes";

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
