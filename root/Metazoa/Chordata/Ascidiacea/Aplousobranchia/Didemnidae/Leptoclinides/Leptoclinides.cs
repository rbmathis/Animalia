using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Didemnidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Didemnidae.Leptoclinides;

/// <summary>
/// Abstract class for Leptoclinides (genus).
/// NCBI TaxId: 322841
/// </summary>
public abstract class Leptoclinides : Didemnidae, ILeptoclinides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leptoclinides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 322841;

    /// <inheritdoc />
    public virtual string GenusName => "Leptoclinides";

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
