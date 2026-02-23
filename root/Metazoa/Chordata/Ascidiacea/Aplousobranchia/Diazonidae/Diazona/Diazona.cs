using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Diazonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Diazonidae.Diazona;

/// <summary>
/// Abstract class for Diazona (genus).
/// NCBI TaxId: 2930582
/// </summary>
public abstract class Diazona : Diazonidae, IDiazona
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Diazona";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2930582;

    /// <inheritdoc />
    public virtual string GenusName => "Diazona";

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
