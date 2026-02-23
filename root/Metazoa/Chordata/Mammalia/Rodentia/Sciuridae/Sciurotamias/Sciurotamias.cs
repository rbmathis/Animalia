using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Sciurotamias;

/// <summary>
/// Abstract class for Sciurotamias (genus).
/// NCBI TaxId: 226848
/// </summary>
public abstract class Sciurotamias : Sciuridae, ISciurotamias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sciurotamias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 226848;

    /// <inheritdoc />
    public virtual string GenusName => "Sciurotamias";

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
