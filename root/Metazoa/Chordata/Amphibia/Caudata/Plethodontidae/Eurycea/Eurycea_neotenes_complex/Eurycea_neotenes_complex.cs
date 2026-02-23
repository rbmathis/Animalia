using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae.Eurycea;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae.Eurycea.Eurycea_neotenes_complex;

/// <summary>
/// Abstract class for Eurycea neotenes complex (no rank).
/// NCBI TaxId: 1406241
/// </summary>
public abstract class Eurycea_neotenes_complex : Eurycea, IEurycea_neotenes_complex
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eurycea neotenes complex";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1406241;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Eurycea_neotenes_complex";
}
