using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Leptodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Leptodactylidae.Adenomera;

/// <summary>
/// Abstract class for Adenomera (genus).
/// NCBI TaxId: 248943
/// </summary>
public abstract class Adenomera : Leptodactylidae, IAdenomera
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Adenomera";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 248943;

    /// <inheritdoc />
    public virtual string GenusName => "Adenomera";

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
