using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Nectariniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Nectariniidae.Aethopyga;

/// <summary>
/// Abstract class for Aethopyga (genus).
/// NCBI TaxId: 181089
/// </summary>
public abstract class Aethopyga : Nectariniidae, IAethopyga
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aethopyga";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 181089;

    /// <inheritdoc />
    public virtual string GenusName => "Aethopyga";

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
