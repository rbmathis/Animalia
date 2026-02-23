using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae.Bitis;

/// <summary>
/// Abstract class for Bitis (genus).
/// NCBI TaxId: 8691
/// </summary>
public abstract class Bitis : Viperidae, IBitis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bitis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8691;

    /// <inheritdoc />
    public virtual string GenusName => "Bitis";

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
