using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Rhodinocichla;

/// <summary>
/// Abstract class for Rhodinocichla (genus).
/// NCBI TaxId: 58202
/// </summary>
public abstract class Rhodinocichla : Thraupidae, IRhodinocichla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhodinocichla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 58202;

    /// <inheritdoc />
    public virtual string GenusName => "Rhodinocichla";

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
