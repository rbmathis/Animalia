using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Leptoscarus;

/// <summary>
/// Abstract class for Leptoscarus (genus).
/// NCBI TaxId: 188115
/// </summary>
public abstract class Leptoscarus : Labridae, ILeptoscarus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leptoscarus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 188115;

    /// <inheritdoc />
    public virtual string GenusName => "Leptoscarus";

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
